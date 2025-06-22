namespace Snake_Game;

public partial class Form1 : Form
{
    private int x = 100; // initial x position
    private int y = 100; // initial y position
    private int objectSize = 30; //Size of the object.


    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        using (var brush = new SolidBrush (Color.Aquamarine) )
        {
            e.Graphics.FillEllipse(brush, x, y, objectSize, objectSize);

        }
    }

    private void OnKeyDown(Object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Left:
                {
                    x -= 5;
                    break;
                }
            case Keys.Right:
                {
                    x += 5;
                    break;
                }
            case Keys.Up:
                {
                    y -= 5;
                    break:

                }
        }
    }
}
