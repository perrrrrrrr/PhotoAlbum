﻿using System;
using System.Linq;
using System.Xml.Serialization;

namespace AlbumWordAddin
{
    public class Rectangle
    {
        public float Left   { get; }
        public float Top    { get; }
        public float Width  { get; }
        public float Height { get; }
        const float Epsilon = .0000001f;

        public Rectangle(float left, float top, float width, float height)
        {
            if (width < float.Epsilon) throw new InvalidOperationException("Rectangle cannot have negative or zero width.");
            if (height < float.Epsilon) throw new InvalidOperationException("Rectangle cannot have negative or zero height.");
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }

        public Rectangle Move(float x, float y)
            => new Rectangle(Left + x, Top + y, Width, Height);

        public Rectangle Grow(float g)
            => Grow(g, g);

        public Rectangle Grow(float w, float h)
            => new Rectangle(Left, Top, Width * w, Height * h);

        public Rectangle Scale(float scale)
            => Scale(scale, scale);

        public Rectangle Scale(float scaleX, float scaleY)
            => new Rectangle(Left * scaleX, Top * scaleY, Width * scaleX, Height * scaleY);

        public Rectangle FitIn(Rectangle other, float fitTopPerc, float fitLeftPerc, float padding) {
            var scale = new[] { other.Width / Width, other.Height / Height }.Min();
            var newWidth  = Width * scale;
            var newHeight = Height * scale;
            var rc=new Rectangle(
                other.Left + (other.Width - newWidth) * fitLeftPerc,
                other.Top + (other.Height - newHeight) * fitTopPerc,
                newWidth,
                newHeight
            );
            if (Math.Abs(padding) < Epsilon ) return rc;
            if (Math.Abs(padding) >=.5f ) throw new InvalidOperationException("Invalid padding ");
            return rc.Move(padding, padding)
                     .Grow(1-2*padding);
        }

        public override string ToString()
            => $"[{Left}..{Left + Width},{Top}..{Top + Height}, ({Width}x{Height})";

        public override bool Equals(object obj)
        {
            var other = obj as Rectangle;
            if (other == null) return false;
            return Math.Abs(Left   - other.Left  ) < Epsilon
                   && Math.Abs(Top    - other.Top   ) < Epsilon
                   && Math.Abs(Width  - other.Width ) < Epsilon
                   && Math.Abs(Height - other.Height) < Epsilon
                ;
        }
        public override int GetHashCode()
        {
            // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
            return base.GetHashCode();
        }
    }
}