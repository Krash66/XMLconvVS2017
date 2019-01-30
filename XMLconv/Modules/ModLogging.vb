Module ModLogging
    Public EnableLogging As Boolean = True
    Public TraceFile As String
    Public errorTrace As String
    Public ODBCTrace As String
    Public AppDataPath As String
    Public IsEventFromCode As Boolean
    Public dlgBrowseFolder As FolderBrowserDialog
    Public objLog As ClsLogging

    Public Const MsgTitle As String = "XML Tool"

    Public Function LoadTextFile(ByVal FilePath As String) As String

        Dim sr As System.IO.StreamReader = Nothing
        Try
            sr = New System.IO.StreamReader(FilePath)
            LoadTextFile = sr.ReadToEnd()

        Catch ex As Exception
            'LogError(ex, "modGeneral LoadTextFile")
            Return ""
        Finally
            If Not sr Is Nothing Then sr.Close()
        End Try

    End Function

    Public Function Log(ByVal sMsg As String, Optional ByVal AddNewLine As Boolean = True) As Boolean
        ClsLogging.LogEvent(sMsg, AddNewLine)
    End Function

    Public Function ErrorLog(ByVal sMsg As String, Optional ByVal AddNewLine As Boolean = True) As Boolean
        ClsLogging.ErrorEvent(sMsg, AddNewLine)
    End Function

    Public Function ODBCErrorLog(ByVal sMsg As String, Optional ByVal AddNewLine As Boolean = True) As Boolean
        ClsLogging.ODBCEvent(sMsg, AddNewLine)
    End Function

    Public Function LogError(ByVal ex As Exception, Optional ByVal p1 As String = "", Optional ByVal p2 As String = "", Optional ByVal ThrowError As Boolean = False, Optional ByVal displayMSG As Boolean = False) As Boolean
        ClsLogging.LogError(ex, p1, p2, ThrowError, displayMSG)
    End Function

    Public Function LogODBCError(ByVal ex As Exception, Optional ByVal p1 As String = "", Optional ByVal p2 As String = "", Optional ByVal ThrowError As Boolean = False, Optional ByVal displayMSG As Boolean = False) As Boolean
        ClsLogging.LogODBCerror(ex, p1, p2, ThrowError, displayMSG)
    End Function

    '//Creates a Logfolder in ..My Documents\Design Studio\Logs\
    Function GetAppLog(Optional ByVal LogFolderName As String = "Logs") As String

        Dim AppData As String = GetAppData()
        'System.Windows.Forms.Application.LocalUserAppDataPath()

        Dim AppTemp As String = ""

        If Right(AppData, 1) <> "\" Then
            AppData = AppData & "\"
        End If

        AppTemp = AppData & LogFolderName & "\"

        If System.IO.Directory.Exists(AppTemp) = False Then
            System.IO.Directory.CreateDirectory(AppTemp)
        End If

        GetAppLog = AppTemp

    End Function

    '//Gets ..My Documents\Design Studio\
    Function GetAppData() As String

        'set Appdata to global variable AppDataPath
        'Dim AppData As String = AppDataPath  'System.Windows.Forms.Application.LocalUserAppDataPath()
        'Dim AppDataPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments() & "\XML Tool\"
        Try
            If AppDataPath = "" Then
                AppDataPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments() & "\XML Tool\"
            End If
            'see if AppData Exists
            If System.IO.Directory.Exists(AppDataPath) = True Then
                GetAppData = AppDataPath
                If Right(GetAppData, 1) <> "\" Then
                    GetAppData = GetAppData & "\"
                End If
                Exit Try
            End If

            Dim diares As DialogResult
tryagain:   diares = MsgBox("The 'XML Tool' Data directory has been moved" & Chr(13) &
                            "or deleted since XML Tool was last opened." & Chr(13) &
                            "How would you like to proceed? :" & Chr(13) &
                            "Create a new 'XML Tool' directory in 'My Documents' (YES)" & Chr(13) &
                            "Browse to new location where directory was moved  (NO)" _
                            , MsgBoxStyle.YesNo,
                            "..\XML Tool Directory Location")
            If diares = DialogResult.Yes Then
                'set AppTemp to ..\MyDocs\XML Tool\
                Dim AppTemp As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments()
                If Right(AppTemp, 1) <> "\" Then
                    AppTemp = AppTemp & "\"
                End If
                AppTemp = AppTemp & "XML Tool\"
                GetAppData = AppTemp
            Else
                dlgBrowseFolder = New FolderBrowserDialog
                dlgBrowseFolder.RootFolder = Environment.SpecialFolder.MyComputer
                dlgBrowseFolder.ShowNewFolderButton = False
                dlgBrowseFolder.Description = "Browse to 'XML Tool' Folder location"
                If dlgBrowseFolder.ShowDialog() = DialogResult.OK Then
                    If dlgBrowseFolder.SelectedPath.Contains("XML Tool") = True Then
                        GetAppData = dlgBrowseFolder.SelectedPath
                        If Right(GetAppData, 1) <> "\" Then
                            GetAppData = GetAppData & "\"
                        End If
                    Else
                        MsgBox("Sorry, you must locate the 'XML Tool' data directory", MsgBoxStyle.OkOnly)
                        GoTo tryagain
                    End If
                Else
                    MsgBox("Sorry, you must locate the 'XML Tool' data directory", MsgBoxStyle.OkOnly)
                    GoTo tryagain
                End If
            End If
            If Right(GetAppData, 1) <> "\" Then
                GetAppData = GetAppData & "\"
            End If
            AppDataPath = GetAppData

        Catch ex As Exception
            LogError(ex, "modGeneral GetAppData")
            GetAppData = AppDataPath
            If Right(GetAppData, 1) <> "\" Then
                GetAppData = GetAppData & "\"
            End If
        End Try

    End Function

    Public Function LoadGlobalValues(Optional ByVal ClearLogOnStartUp As Boolean = True) As Boolean

        objLog = New ClsLogging

        Try
            If TraceFile Is Nothing Then
                TraceFile = "Trace.log"
            End If
            If errorTrace Is Nothing Then
                errorTrace = "ErrorTrc.log"
            End If
            If ODBCTrace Is Nothing Then
                ODBCTrace = "ODBCErrLog.log"
            End If
            If ClearLogOnStartUp = True Then
                System.IO.File.Delete(GetAppLog() & TraceFile)  '
                System.IO.File.Delete(GetAppLog() & errorTrace)   '& "\"
                System.IO.File.Delete(GetAppLog() & ODBCTrace)
                'System.IO.File.Delete(GetAppPath() & "*.log")
            End If
            EnableLogging = True
            If Not System.IO.File.Exists(GetAppLog() & TraceFile) Then
                System.IO.File.Create(GetAppLog() & TraceFile)
            End If
            If Not System.IO.File.Exists(GetAppLog() & errorTrace) Then
                System.IO.File.Create(GetAppLog() & errorTrace)
            End If
            If Not System.IO.File.Exists(GetAppLog() & ODBCTrace) Then
                System.IO.File.Create(GetAppLog() & ODBCTrace)
            End If

            'Log("Trace Enabled")
            Return True

        Catch ex As Exception
            LogError(ex, "modDeclares LoadGlobalValues")
            Return False
        End Try

    End Function
End Module
