﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class PolygonShape : Polygon
    {
        #region Constructor

        public PolygonShape(RectangleF rect, List<PointF> vertices) : base(rect)
        {
            this.Vertices = vertices;
        }

        #endregion

        #region Properties
        private List<PointF> Vertices { get; set; }
        public int Id = 0;

        #endregion
      
        //private bool IsPointInsideConvexPolygon(PointF point)
        //{
        //    int n = Vertices.Count;
        //    byte sign = 0;

        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        float dx1 = Vertices[(i + 1) % n].X - Vertices[i].X;
        //        float dy1 = Vertices[(i + 1) % n].Y - Vertices[i].Y;

        //        float dx2 = point.X - Vertices[i].X;
        //        float dy2 = point.Y - Vertices[i].Y;


        //    }

        //    return false;
        //}

        //public override bool Contains(PointF point)
        //{
        //    bool inside = false;

        //    float ray = float.MaxValue;
        //    float eps = 0.0001f;

        //    Dictionary<PointF, PointF> edges = new Dictionary<PointF, PointF>();

        //    for (int i = 0; i < Vertices.Count - 1; i++)
        //    {
        //        edges.Add(Vertices[i], Vertices[i + 1]);
        //    }

        //    foreach (var edge in edges)
        //    {
        //        PointF A = edge.Key;
        //        PointF B = edge.Value;

        //        if (A.Y > B.Y)
        //        {
        //            PointF temp = A;
        //            A = B;
        //            B = temp;
        //        }

        //        if (point.Y == A.Y || point.Y == B.Y)
        //            point.Y += eps;

        //        if (point.Y < B.Y || point.Y > A.Y || point.X > Math.Max(A.X, B.X))
        //            continue;

        //        if (point.X < Math.Min(A.X, B.X))
        //        {
        //            inside = true;
        //            continue;
        //        }

        //        PointF AB = new PointF(B.X - A.X, B.Y - A.Y);
        //        PointF PB = new PointF(B.X - point.X, B.Y - point.Y);

        //        if (PB.X > AB.X || PB.Y > AB.Y)
        //        {
        //            inside = true;
        //        }

        //        float m_edge;
        //        float m_point;

        //        try
        //        {
        //            m_edge = (B.Y - A.Y) / (B.X - A.X);
        //        }
        //        catch (DivideByZeroException)
        //        {
        //            m_edge = ray;
        //        }

        //        try
        //        {
        //            m_point = (point.X - A.Y) / (point.X - A.X);
        //        }
        //        catch (DivideByZeroException)
        //        {
        //            m_point = ray;
        //        }

        //        if (m_point >= m_edge)
        //        {
        //            inside = true;
        //            continue;
        //        }
        //    }

        //    return inside;
        //}
    
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillPolygon(new SolidBrush(FillColor), this.Vertices.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor), this.Vertices.ToArray());
        }
    }
}
