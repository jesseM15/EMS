Imports EMSlib.EMS

Public Class Messages
    Private _view As String
    Private _messageList As Collection

    Public Sub New()
        _view = "Inbox"
        _messageList = New Collection()
    End Sub

    Public Property view() As String
        Get
            Return _view
        End Get
        Set(value As String)
            _view = value
        End Set
    End Property

    Public Property messageList As Collection
        Get
            Return _messageList
        End Get
        Set(value As Collection)
            _messageList = value
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
        _messageList = dbems.getInboxMessages(user.id)
        Dim msgstr(2) As String
        Dim lvi As New ListViewItem
        For Each msg In _messageList
            msgstr(0) = dbems.getUserName(msg.senderId)
            msgstr(1) = msg.timeStamp.ToString()
            msgstr(2) = msg.message
            lvi = New ListViewItem(msgstr)
            Form1.lsvMessages.Items.Add(lvi)
        Next
    End Sub

    Private Sub initSent()
        _messageList = dbems.getSentMessages(user.id)
        Dim msgstr(2) As String
        Dim lvi As New ListViewItem
        For Each msg In _messageList
            msgstr(0) = dbems.getUserName(msg.userId)
            msgstr(1) = msg.timeStamp.ToString()
            msgstr(2) = msg.message
            lvi = New ListViewItem(msgstr)
            Form1.lsvMessages.Items.Add(lvi)
        Next
    End Sub

    Private Sub initViewed()
        _messageList = dbems.getViewedMessages(user.id)
        Dim msgstr(2) As String
        Dim lvi As New ListViewItem
        For Each msg In _messageList
            msgstr(0) = dbems.getUserName(msg.senderId)
            msgstr(1) = msg.timeStamp.ToString()
            msgstr(2) = msg.message
            lvi = New ListViewItem(msgstr)
            Form1.lsvMessages.Items.Add(lvi)
        Next
    End Sub

    Public Sub displayMessage(ByVal e As MouseEventArgs)
        Dim msgItem As ListViewItem = Form1.lsvMessages.GetItemAt(e.X, e.Y)
        Dim caption As String = _view & " Message"
        Dim msg As String = Form1.lsvMessages.Columns(0).Text & ": " & msgItem.SubItems(0).Text & " on "
        msg += msgItem.SubItems(1).Text & vbCrLf & vbCrLf
        msg += msgItem.SubItems(2).Text
        MessageBox.Show(msg, caption)
        If _view = "Inbox" Then
            dbems.setMessageViewed(_messageList(msgItem.Index + 1).id())
            initMessagesPanel()
        End If
    End Sub

End Class
