Namespace Practicals.Practical09.Forms
    Partial Class P09SignUp
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 79)
            Me.Label1.Margin = New System.Windows.Forms.Padding(10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(113, 29)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Username"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 174)
            Me.Label2.Margin = New System.Windows.Forms.Padding(10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(105, 29)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Password"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 269)
            Me.Label3.Margin = New System.Windows.Forms.Padding(10)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(180, 29)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Repeat Password"
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(15, 118)
            Me.TextBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
            Me.TextBox1.MaxLength = 16
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(237, 36)
            Me.TextBox1.TabIndex = 3
            '
            'TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(15, 213)
            Me.TextBox2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
            Me.TextBox2.MaxLength = 16
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(237, 36)
            Me.TextBox2.TabIndex = 4
            '
            'TextBox3
            '
            Me.TextBox3.Location = New System.Drawing.Point(15, 308)
            Me.TextBox3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
            Me.TextBox3.MaxLength = 16
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(237, 36)
            Me.TextBox3.TabIndex = 5
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(10, 20)
            Me.Label4.Margin = New System.Windows.Forms.Padding(10, 20, 20, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(87, 29)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Sign Up"
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Location = New System.Drawing.Point(212, 4)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(52, 26)
            Me.Button1.TabIndex = 7
            Me.Button1.Text = "Back"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'P09SignUp
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TextBox3)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "P09SignUp"
            Me.Size = New System.Drawing.Size(267, 363)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents TextBox2 As TextBox
        Friend WithEvents TextBox3 As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents Button1 As Button
    End Class

End Namespace