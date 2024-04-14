using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge_Pattern
{
    public interface IRender
    {
        void RenderCircle(float radius);
    }

    public class VectorRender : IRender
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a Circle of Radius : {radius}");
        }
    }

    public class RasterRender : IRender
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing Pixeles for Circle with Radius : {radius}");
        }
    }

    public abstract class Shape
    {
        protected IRender render;
        protected Shape(IRender render)
        {
            this.render = render;
        }
        public abstract void Draw();
        public abstract void Resize(float factor);
    }

    public class Circle : Shape
    {
        float radius;
        public Circle(IRender render, float radius) : base(render)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            render.RenderCircle(radius);
        }

        public override void Resize(float factor)
        {
            radius *= factor;
        }
    }

}
