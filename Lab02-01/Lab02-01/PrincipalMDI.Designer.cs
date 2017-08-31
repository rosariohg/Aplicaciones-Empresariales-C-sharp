namespace Lab02_01
{
    partial class PrincipalMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepInventarioProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteProv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(152, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(152, 22);
            this.mnuManProductos.Text = "Productos";
            this.mnuManProductos.Click += new System.EventHandler(this.mnuManProductos_Click);
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(152, 22);
            this.mnuManCategorias.Text = "Categorias";
            this.mnuManCategorias.Click += new System.EventHandler(this.mnuManCategorias_Click);
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(152, 22);
            this.mnuManProveedores.Text = "Proveedores";
            this.mnuManProveedores.Click += new System.EventHandler(this.mnuManProveedores_Click);
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(152, 22);
            this.mnuManClientes.Text = "Clientes";
            this.mnuManClientes.Click += new System.EventHandler(this.mnuManClientes_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRegistrarVenta,
            this.mnuProRegistrarCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProRegistrarVenta
            // 
            this.mnuProRegistrarVenta.Name = "mnuProRegistrarVenta";
            this.mnuProRegistrarVenta.Size = new System.Drawing.Size(166, 22);
            this.mnuProRegistrarVenta.Text = "Registrar Venta";
            this.mnuProRegistrarVenta.Click += new System.EventHandler(this.mnuProRegistrarVenta_Click);
            // 
            // mnuProRegistrarCompra
            // 
            this.mnuProRegistrarCompra.Name = "mnuProRegistrarCompra";
            this.mnuProRegistrarCompra.Size = new System.Drawing.Size(166, 22);
            this.mnuProRegistrarCompra.Text = "Registrar Compra";
            this.mnuProRegistrarCompra.Click += new System.EventHandler(this.mnuProRegistrarCompra_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepReporteVentas,
            this.mnuRepReporteCompras,
            this.mnuRepInventarioProductos,
            this.mnuRepReporteProv,
            this.mnuRepReporteUsuarios,
            this.mnuRepReporteClientes});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // mnuRepReporteVentas
            // 
            this.mnuRepReporteVentas.Name = "mnuRepReporteVentas";
            this.mnuRepReporteVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteVentas.Text = "Reporte de Ventas";
            this.mnuRepReporteVentas.Click += new System.EventHandler(this.mnuRepReporteVentas_Click);
            // 
            // mnuRepReporteCompras
            // 
            this.mnuRepReporteCompras.Name = "mnuRepReporteCompras";
            this.mnuRepReporteCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteCompras.Text = "Reporte de Compras";
            this.mnuRepReporteCompras.Click += new System.EventHandler(this.mnuRepReporteCompras_Click);
            // 
            // mnuRepInventarioProductos
            // 
            this.mnuRepInventarioProductos.Name = "mnuRepInventarioProductos";
            this.mnuRepInventarioProductos.Size = new System.Drawing.Size(200, 22);
            this.mnuRepInventarioProductos.Text = "Inventario de Productos";
            this.mnuRepInventarioProductos.Click += new System.EventHandler(this.mnuRepInventarioProductos_Click);
            // 
            // mnuRepReporteProv
            // 
            this.mnuRepReporteProv.Name = "mnuRepReporteProv";
            this.mnuRepReporteProv.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteProv.Text = "Reporte de Proveedores";
            this.mnuRepReporteProv.Click += new System.EventHandler(this.mnuRepReporteProv_Click);
            // 
            // mnuRepReporteUsuarios
            // 
            this.mnuRepReporteUsuarios.Name = "mnuRepReporteUsuarios";
            this.mnuRepReporteUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteUsuarios.Text = "Reporte de Usuarios";
            this.mnuRepReporteUsuarios.Click += new System.EventHandler(this.mnuRepReporteUsuarios_Click);
            // 
            // mnuRepReporteClientes
            // 
            this.mnuRepReporteClientes.Name = "mnuRepReporteClientes";
            this.mnuRepReporteClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteClientes.Text = "Reporte de Clientes";
            this.mnuRepReporteClientes.Click += new System.EventHandler(this.mnuRepReporteClientes_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistemaSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSistemaSalir
            // 
            this.mnuSistemaSalir.Name = "mnuSistemaSalir";
            this.mnuSistemaSalir.Size = new System.Drawing.Size(158, 22);
            this.mnuSistemaSalir.Text = "Salir del sistema";
            this.mnuSistemaSalir.Click += new System.EventHandler(this.mnuSistemaSalir_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab02_01.Properties.Resources.ventas;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepInventarioProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteProv;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteClientes;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaSalir;
    }
}