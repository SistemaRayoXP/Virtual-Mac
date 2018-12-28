<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ConsoleIO = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ConsoleIO
        '
        Me.ConsoleIO.BackColor = System.Drawing.SystemColors.WindowText
        Me.ConsoleIO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsoleIO.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsoleIO.ForeColor = System.Drawing.SystemColors.Window
        Me.ConsoleIO.Location = New System.Drawing.Point(0, 0)
        Me.ConsoleIO.Multiline = True
        Me.ConsoleIO.Name = "ConsoleIO"
        Me.ConsoleIO.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ConsoleIO.Size = New System.Drawing.Size(605, 398)
        Me.ConsoleIO.TabIndex = 0
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 398)
        Me.Controls.Add(Me.ConsoleIO)
        Me.Name = "frmDebug"
        Me.Text = "Configuration Values"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConsoleIO As System.Windows.Forms.TextBox
End Class
