    using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class RoundedForm
{
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,     // x-coord de arriba izq 
        int nTopRect,      // y-coord de arriba derecha
        int nRightRect,    // x-coord esquina inferior derecha
        int nBottomRect,   // y-coord esquina inferior izquierda
        int nWidthEllipse, // ancho de la elipse
        int nHeightEllipse // alatura de elipse
    );

    // Método para redondear bordes de un formulario
    public static void ApplyRoundCorners(Form form, int cornerRadius)
    {
        if (form.IsHandleCreated)
        {
            IntPtr ptr = CreateRoundRectRgn(0, 0, form.Width, form.Height, cornerRadius, cornerRadius);
            form.Region = Region.FromHrgn(ptr);
        }
    }
    public static void ApplyRoundCorners(Control control, int cornerRadius)
    {
        // Crear un camino gráfico con bordes redondos
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Esquina superior izquierda
        path.AddArc(control.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Esquina superior derecha
        path.AddArc(control.Width - cornerRadius, control.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Esquina inferior derecha
        path.AddArc(0, control.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Esquina inferior izquierda
        path.CloseFigure();

        // Asignar la región al control
        control.Region = new Region(path);
    }
}