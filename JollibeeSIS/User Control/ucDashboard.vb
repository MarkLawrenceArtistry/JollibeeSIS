Imports System.Data.SqlClient

Public Class ucDashboard

    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the methods to load all dashboard data when the control loads
        LoadDashboardCards()
        LoadTopSellingItems()
        LoadLowStockItems()
    End Sub

    Private Sub LoadDashboardCards()
        Try
            OpenConnection()

            ' --- Query 1: Get Total Sales for Today ---
            Dim cmdSales As New SqlCommand("SELECT SUM(TotalAmount) FROM tblSalesMaster WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)", conn)
            Dim totalSales As Object = cmdSales.ExecuteScalar()
            If totalSales IsNot DBNull.Value Then
                lblTodaysSales.Text = "₱" & Convert.ToDecimal(totalSales).ToString("N2")
            Else
                lblTodaysSales.Text = "₱0.00"
            End If

            ' --- Query 2: Get Total Number of Transactions Today ---
            Dim cmdTransactions As New SqlCommand("SELECT COUNT(SaleID) FROM tblSalesMaster WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)", conn)
            Dim totalTransactions As Object = cmdTransactions.ExecuteScalar()
            lblTransactions.Text = If(totalTransactions IsNot DBNull.Value, totalTransactions.ToString(), "0")

            ' --- Query 3: Get Total Quantity of Items Sold Today ---
            Dim queryItemsSold As String = "SELECT SUM(sd.Quantity) FROM tblSalesDetail sd " &
                                           "INNER JOIN tblSalesMaster sm ON sd.SaleID = sm.SaleID " &
                                           "WHERE CAST(sm.SaleDate AS DATE) = CAST(GETDATE() AS DATE)"
            Dim cmdItems As New SqlCommand(queryItemsSold, conn)
            Dim totalItems As Object = cmdItems.ExecuteScalar()
            lblItemsSold.Text = If(totalItems IsNot DBNull.Value, totalItems.ToString(), "0")

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard card data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub LoadTopSellingItems()
        Try
            OpenConnection()
            Dim query As String = "SELECT TOP 5 p.ProductName AS [Product Name], SUM(sd.Quantity) AS [Quantity Sold] " &
                                  "FROM tblSalesDetail sd " &
                                  "INNER JOIN tblProducts p ON sd.ProductID = p.ProductID " &
                                  "INNER JOIN tblSalesMaster sm ON sd.SaleID = sm.SaleID " &
                                  "WHERE CAST(sm.SaleDate AS DATE) = CAST(GETDATE() AS DATE) " &
                                  "GROUP BY p.ProductName " &
                                  "ORDER BY [Quantity Sold] DESC"

            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvTopSelling.DataSource = dt

            ' --- APPLY THE NEW STYLE ---
            StyleDataGridView(dgvTopSelling)

        Catch ex As Exception
            MessageBox.Show("Error loading top selling items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub LoadLowStockItems()
        Try
            OpenConnection()
            ' We define "Low Stock" as quantity 10 or less
            Dim query As String = "SELECT ProductName AS [Product Name], StockQuantity AS [Remaining Stock] " &
                                  "FROM tblProducts " &
                                  "WHERE StockQuantity <= 10 " &
                                  "ORDER BY StockQuantity ASC"

            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvLowStock.DataSource = dt

            ' --- APPLY THE NEW STYLE ---
            StyleDataGridView(dgvLowStock)

        Catch ex As Exception
            MessageBox.Show("Error loading low stock items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Public Sub StyleDataGridView(ByVal dgv As Guna.UI2.WinForms.Guna2DataGridView)
        ' Define your brand colors
        Dim jollibeeRed As Color = Color.FromArgb(218, 0, 27)
        Dim jollibeeBlack As Color = Color.FromArgb(54, 54, 54)
        Dim lightGray As Color = Color.FromArgb(249, 249, 249) ' For alternating rows
        Dim selectionColor As Color = Color.FromArgb(254, 237, 238) ' A very light Jollibee red

        ' --- GENERAL STYLE ---
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.BackgroundColor = Color.White
        dgv.RowHeadersVisible = False
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' --- HEADER STYLE ---
        dgv.ColumnHeadersVisible = True ' THIS IS THE MOST IMPORTANT FIX
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = jollibeeBlack
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgv.ColumnHeadersDefaultCellStyle.BackColor
        dgv.ColumnHeadersHeight = 40
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.EnableHeadersVisualStyles = False

        ' --- ROW STYLE ---
        dgv.RowsDefaultCellStyle.BackColor = Color.White
        dgv.RowsDefaultCellStyle.Font = New Font("Segoe UI", 9.0F)
        dgv.RowsDefaultCellStyle.ForeColor = jollibeeBlack
        dgv.RowsDefaultCellStyle.SelectionBackColor = selectionColor
        dgv.RowsDefaultCellStyle.SelectionForeColor = jollibeeBlack
        dgv.RowTemplate.Height = 35

        ' --- ALTERNATING ROW STYLE ---
        dgv.AlternatingRowsDefaultCellStyle.BackColor = lightGray
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = selectionColor

        ' --- GRID COLOR ---
        dgv.GridColor = Color.FromArgb(231, 229, 255)
    End Sub

    'daugdaug
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click, Label3.Click

    End Sub
End Class