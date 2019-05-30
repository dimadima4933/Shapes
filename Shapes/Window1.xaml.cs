﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shapes
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //line1.RenderTransformOrigin = new Point(0.5, 0.5);
        }

        private void ellipse1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse myEllipse = new Ellipse();
            myEllipse.Stroke = Brushes.Black;
            myEllipse.Fill = Brushes.DarkBlue;
            myEllipse.HorizontalAlignment = HorizontalAlignment.Left;
            myEllipse.VerticalAlignment = VerticalAlignment.Center;
            myEllipse.Width = 50;
            myEllipse.Height = 75;
            Canvas.SetLeft(myEllipse, 300);
            Canvas.SetTop(myEllipse, 100);

            canvas1.Children.Add(myEllipse);

            //w1.Content = myEllipse;

            e.Handled = true;
        }

        private void rectangle1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle myRect = new Rectangle();
            myRect.Stroke = Brushes.Black;
            myRect.Fill = Brushes.SkyBlue;
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            myRect.Height = 50;
            myRect.Width = 50;
            w1.Content = myRect;
        }

        private void Poly1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = Brushes.Black;
            myPolygon.Fill = Brushes.LightSeaGreen;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            Point Point1 = new Point(1, 50);
            Point Point2 = new Point(10, 80);
            Point Point3 = new Point(50, 50);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPolygon.Points = myPointCollection;
            this.Content = myPolygon;
        }

        private void pline1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Polyline myPolyline = new Polyline();
            myPolyline.Stroke = Brushes.SlateGray;
            myPolyline.StrokeThickness = 2;
            Point Point4 = new Point(1, 50);
            Point Point5 = new Point(10, 80);
            Point Point6 = new Point(20, 40);
            PointCollection myPointCollection2 = new PointCollection();
            myPointCollection2.Add(Point4);
            myPointCollection2.Add(Point5);
            myPointCollection2.Add(Point6);
            myPolyline.Points = myPointCollection2;
            this.Content = myPolyline;
        }

        private void Line_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.LightSteelBlue;
            myLine.X1 = 1;
            myLine.X2 = 50;
            myLine.Y1 = 1;
            myLine.Y2 = 50;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            this.Content = myLine;

        }

        private void Path_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Создание фигуры, которая может содержать много сегментов
            PathFigure myPathFigure = new PathFigure();

            // Указать координаты начала фигуры
            myPathFigure.StartPoint = new Point(10, 50);

            QuadraticBezierSegment qSegment = new QuadraticBezierSegment(new Point(500, 500), new Point(500, 100), true);

            // Добавить линейный сегмент в фигуру
            LineSegment myLineSegment = new LineSegment();
            myLineSegment.Point = new Point(200, 70);

            // Добавить сегмент - кривую Безье в фигуру
            BezierSegment myBezierSegment = new BezierSegment(new Point(300, 100), new Point(100, 300), new Point(300, 300), true);

            /*BezierSegment myBezierSegment = new BezierSegment();
            myBezierSegment.Point1 = new Point(100, 200);
            myBezierSegment.Point2 = new Point(200, 0);
            myBezierSegment.Point3 = new Point(300, 100);*/

            // Создание коллекции сегментов, содержащий все сегменты одной фигуры
            PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
            myPathSegmentCollection.Add(myBezierSegment);
            myPathSegmentCollection.Add(myLineSegment);
            myPathSegmentCollection.Add(qSegment);

            // Добавление коллекции сегметов в фигуру
            myPathFigure.Segments = myPathSegmentCollection;

            // Создание коллекции фигур контура, в которую можно добавлять любое количество фигур
            PathFigureCollection myPathFigureCollection = new PathFigureCollection();
            myPathFigureCollection.Add(myPathFigure);

            // Создание геометрии контура на основе коллекции фигур контура
            PathGeometry myPathGeometry = new PathGeometry();
            myPathGeometry.Figures = myPathFigureCollection;

            // Создание контура с указанной геометрией контура
            Path myPath = new Path();
            myPath.Stroke = Brushes.Black;
            myPath.StrokeThickness = 15;
            myPath.StrokeStartLineCap = PenLineCap.Round;
            myPath.StrokeEndLineCap = PenLineCap.Round;
            myPath.StrokeDashCap = PenLineCap.Round;
            myPath.Data = myPathGeometry;
            this.Content = myPath;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Ellipse myEllipse = new Ellipse();
            myEllipse.Stroke = Brushes.Black;
            myEllipse.Fill = Brushes.Red;
            myEllipse.Width = 50;
            myEllipse.Height = 75;
            Canvas.SetLeft(myEllipse, 10);
            Canvas.SetTop(myEllipse, 10);
            canvas1.Children.Add(myEllipse);
        }

        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse myEllipse = new Ellipse();
            myEllipse.Stroke = Brushes.Black;
            myEllipse.Fill = Brushes.DarkBlue;
            myEllipse.HorizontalAlignment = HorizontalAlignment.Left;
            myEllipse.VerticalAlignment = VerticalAlignment.Center;
            myEllipse.Width = 50;
            myEllipse.Height = 75;

            Point coords = e.GetPosition(canvas1);
            Canvas.SetLeft(myEllipse, coords.X);
            Canvas.SetTop(myEllipse, coords.Y);

            canvas1.Children.Add(myEllipse);
        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            //Point coords = e.GetPosition(canvas1);
            //Canvas.SetLeft(ellipse1, coords.X);
            //Canvas.SetTop(ellipse1, coords.Y);
        }
    }
}
