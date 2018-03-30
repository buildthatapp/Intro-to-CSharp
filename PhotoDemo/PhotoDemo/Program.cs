using System;
using static System.Console;


class PhotoDemo
{
    static void Main()
    {
        // standard 8x10, default constructor
        Photo stdPhoto = new Photo();
        stdPhoto.Width = 8;
        stdPhoto.Height = 10;

        // custom 8x9, constructor with two named arguments
        Photo customPhoto = new Photo(height: 9, width: 8);

        // matted 10x12, constructor with three arguments
        MattedPhoto largeMatted = new MattedPhoto(10, 12, "White");

        // framed 10x10, constructor with two arguments
        FramedPhoto customFramed = new FramedPhoto(10, 10);
        customFramed.Material = "Silver";
        customFramed.Style = "Formal";

        // use ToString() methods to print state of all objects
        WriteLine(stdPhoto.ToString());
        WriteLine(customPhoto.ToString());
        WriteLine(largeMatted.ToString());
        WriteLine(customFramed.ToString());
    }
}

class Photo
{
   
    protected int width;
    protected int height;
    protected decimal PREMIUM = 0.00m;

    public Photo()
    {
        
    }
    public Photo(int height, int width)
    {

        this.height = height;
        this.width = width;

    }
    

    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public decimal Price
    {

     

            get
        {
            if (height == 10 && width == 8) return 3.99m;
            else if (height == 12 && width == 10) return 5.99m;
            else return 9.99m;
        }


      
       
    }
    



    public override string ToString()
    {
        string temp = width + " X " + height + " " + GetType() + " Price: " + Price.ToString("C2");

        return temp;
    }



}

class MattedPhoto : Photo
{
    private string color;
    

    public string Color
    {
        get { return color; }
        set { color = value; }

    }

    public override string ToString()
    {
        string temp = width + " X " + height + " " + GetType() + " Matted: " + color + " Price: " + Price.ToString("C2");

        return temp;
    }

    public MattedPhoto(int Width, int Height, string Color)
    {
        width = Width;
        height = Height;
        color = Color;
        
      
    }

    public  decimal Price
    {



        get { return base.Price + 10.00m; ; }




    }


}

class FramedPhoto : Photo
{
    
    private string material;
    private string style;

    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    public string Style
    {
        get { return style; }
        set { style = value; }
    }

    public override string ToString()
    {
        string temp = width + " X " + height + " " + GetType() + " Frame: " + material + " " + style + " Price: " + Price.ToString("C2");

        return temp;
    }

    public FramedPhoto(int Width, int Height)
    {
        
        width = Width;
        height = Height;
        material = "Silver";
        style = "Formal";
       
    }
    public  decimal Price
    {



        get { return base.Price + 25.00m; ; }




    }
}


