<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class telaPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.quadro = New System.Windows.Forms.PictureBox()
        Me.resetaTela = New System.Windows.Forms.Button()
        Me.curvaBezierCubica = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.curvaBezierQuadratica = New System.Windows.Forms.Button()
        CType(Me.quadro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'quadro
        '
        Me.quadro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quadro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.quadro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.quadro.Location = New System.Drawing.Point(0, 0)
        Me.quadro.Name = "quadro"
        Me.quadro.Size = New System.Drawing.Size(943, 514)
        Me.quadro.TabIndex = 0
        Me.quadro.TabStop = False
        '
        'resetaTela
        '
        Me.resetaTela.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.resetaTela.Location = New System.Drawing.Point(0, 634)
        Me.resetaTela.Name = "resetaTela"
        Me.resetaTela.Size = New System.Drawing.Size(943, 61)
        Me.resetaTela.TabIndex = 1
        Me.resetaTela.Text = "Resetar Tela"
        Me.resetaTela.UseVisualStyleBackColor = True
        '
        'curvaBezierCubica
        '
        Me.curvaBezierCubica.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.curvaBezierCubica.Location = New System.Drawing.Point(0, 577)
        Me.curvaBezierCubica.Name = "curvaBezierCubica"
        Me.curvaBezierCubica.Size = New System.Drawing.Size(943, 57)
        Me.curvaBezierCubica.TabIndex = 2
        Me.curvaBezierCubica.Text = "Traçar curva de Bezier Cúbica"
        Me.curvaBezierCubica.UseVisualStyleBackColor = True
        '
        'curvaBezierQuadratica
        '
        Me.curvaBezierQuadratica.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.curvaBezierQuadratica.Location = New System.Drawing.Point(0, 520)
        Me.curvaBezierQuadratica.Name = "curvaBezierQuadratica"
        Me.curvaBezierQuadratica.Size = New System.Drawing.Size(943, 57)
        Me.curvaBezierQuadratica.TabIndex = 3
        Me.curvaBezierQuadratica.Text = "Traçar curva de Bezier quadrática"
        Me.curvaBezierQuadratica.UseVisualStyleBackColor = True
        '
        'telaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 695)
        Me.Controls.Add(Me.curvaBezierQuadratica)
        Me.Controls.Add(Me.curvaBezierCubica)
        Me.Controls.Add(Me.resetaTela)
        Me.Controls.Add(Me.quadro)
        Me.Name = "telaPrincipal"
        Me.Text = "Tela Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.quadro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents quadro As PictureBox
    Friend WithEvents resetaTela As Button
    Friend WithEvents curvaBezierCubica As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents curvaBezierQuadratica As Button
End Class
