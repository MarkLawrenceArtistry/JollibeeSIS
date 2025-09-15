Public Class ucProductCard
    ' Public properties to hold data for this specific card
    Public Property ProductID As Integer

    ' FIX 1: Added the 'Shadows' keyword to resolve the warning.
    ' This tells VB that we are intentionally creating a property with a similar name
    ' to one in the base class.
    Public Shadows Property ProductName As String
        Get
            Return lblName.Text
        End Get
        Set(value As String)
            lblName.Text = value
        End Set
    End Property

    Public Property ProductPrice As Decimal
        Get
            ' FIX 2: Replaced modern string interpolation with classic concatenation.
            Return Decimal.Parse(lblPrice.Text.Replace("₱", ""))
        End Get
        Set(value As Decimal)
            ' FIX 3: Replaced modern string interpolation with classic concatenation and .ToString() formatting.
            lblPrice.Text = "₱" & value.ToString("N2")
        End Set
    End Property

    Public Property ProductImage As Image
        Get
            Return picImage.Image
        End Get
        Set(value As Image)
            picImage.Image = value
        End Set
    End Property

    ' Custom Event: This will tell the main POS form that this specific card was clicked
    Public Event ProductClicked(sender As Object, e As EventArgs)

    ' We will raise the event when any part of the card is clicked.
    ' FIX 4: Corrected the typo "e As As EventArgs" to "e As EventArgs".
    ' This was the cause of most of the errors.
    Private Sub Card_Click(sender As Object, e As EventArgs) Handles MyBase.Click, picImage.Click, lblName.Click, lblPrice.Click
        RaiseEvent ProductClicked(Me, e)
    End Sub
End Class