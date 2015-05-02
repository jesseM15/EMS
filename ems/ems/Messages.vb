Imports EMSlib.EMS

Public Class Messages
    Dim _view As String

    Public Sub New()
        _view = "Inbox"
    End Sub

    Public Property view() As String
        Get
            Return _view
        End Get
        Set(value As String)
            _view = value
        End Set
    End Property

    Public Sub initMessagesPanel()
        Form1.lblMessagesView.Text = _view
        Form1.lsvMessages.Columns.Clear()
        Form1.lsvMessages.Items.Clear()
        Form1.lsvMessages.Columns.Add("Sender", 120, HorizontalAlignment.Left)
        If _view = "Sent" Then
            Form1.lsvMessages.Columns.Item(0).Text = "Sent To"
        End If
        Form1.lsvMessages.Columns.Add("Date", 140, HorizontalAlignment.Left)
        Form1.lsvMessages.Columns.Add("Message", 258, HorizontalAlignment.Left)
        If _view = "Inbox" Then
            initInbox()
        ElseIf _view = "Sent" Then
            initSent()
        ElseIf _view = "Viewed" Then
            initViewed()
        End If
        Form1.pnlMessages.Visible = True
    End Sub

    Private Sub initInbox()
        Dim msgs As Collection = dbems.getInboxMessages(user.id)
        Dim msgstr(2) As String
        Dim lvi As New ListViewItem
        For Each msg In msgs
            msgstr(0) = dbems.getUserName(msg.senderId)
            msgstr(1) = msg.timeStamp.ToString()
            msgstr(2) = msg.message
            lvi = New ListViewItem(msgstr)
            Form1.lsvMessages.Items.Add(lvi)
        Next
    End Sub

    Private Sub initSent()
        Dim msgs As Collection = dbems.getSentMessages(user.id)
        Dim msgstr(2) As String
        Dim lvi As New ListViewItem
        For Each msg In msgs
            msgstr(0) = dbems.getUserName(msg.userId)
            msgstr(1) = msg.timeStamp.ToString()
            msgstr(2) = msg.message
            lvi = New ListViewItem(msgstr)
            Form1.lsvMessages.Items.Add(lvi)
        Next
    End Sub

    Private Sub initViewed()
        Dim msgs As Collection = dbems.getViewedMessages(user.id)
        Dim msgstr(2) As String
        Dim lvi As New ListViewItem
        For Each msg In msgs
            msgstr(0) = dbems.getUserName(msg.senderId)
            msgstr(1) = msg.timeStamp.ToString()
            msgstr(2) = msg.message
            lvi = New ListViewItem(msgstr)
            Form1.lsvMessages.Items.Add(lvi)
        Next
    End Sub

End Class
