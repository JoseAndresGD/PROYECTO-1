'
' Created by SharpDevelop.
' User: S1015
' Date: 16/02/2023
' Time: 02:41 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MostrarDepartamento
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dgvDatos
		'
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(12, 12)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.Size = New System.Drawing.Size(377, 211)
		Me.dgvDatos.TabIndex = 0
		'
		'MostrarDepartamento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(401, 237)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "MostrarDepartamento"
		Me.Text = "MostrarDepartamento"
		AddHandler Load, AddressOf Me.MostrarDepartamentoLoad
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private dgvDatos As System.Windows.Forms.DataGridView
End Class
