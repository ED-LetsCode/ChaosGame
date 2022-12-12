using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosGame
{
    /// <summary>
    /// Class for drawing some of the images from the Chaos game
    /// </summary>
    public class Shape
    {
        public int ImgHeight { get; set; }
        public int ImgWidth { get; set; }
        public Color Color { get; set; }

        private Random _random = new Random();
        private Point _startPoint;

        public Shape(int imgWidth, int imgHeight, Color color)
        {
            ImgHeight = imgHeight;
            ImgWidth = imgWidth;
            Color = color;

            //Set random start point for every shape
            _startPoint = new Point(_random.Next(0, imgWidth), _random.Next(0, imgHeight));
        }

        /// <summary>
        /// Get shape points
        /// </summary>
        /// <param name="iterations">Number of repeats</param>
        /// <param name="formPattern">ENUM FormPattern</param>
        /// <returns>List of points for every point from shape</returns>
        /// <exception cref="Exception">Pattern not found</exception>
        private List<PointF> GetShapePoints(int iterations, FormPattern formPattern)
        {
            List<PointF> allPoints = new();
            switch (formPattern)
            {
                case FormPattern.Triangle:
                    allPoints.AddRange(GetTrianglePoints(iterations));
                    break;

                case FormPattern.Square1:
                    allPoints.AddRange(GetSquare1Points(iterations));
                    break;

                case FormPattern.Square2:
                    allPoints.AddRange(GetSquare2Points(iterations));
                    break;

                case FormPattern.Square3:
                    allPoints.AddRange(GetSquare3Points(iterations));
                    break;

                case FormPattern.Pentagon:
                    allPoints.AddRange(GetPentagonPoints(iterations));
                    break;

                default:
                    throw new Exception("Pattern not found, enter a valid Pattern => see FormPattern enum");
            }
            return allPoints;
        }

        /// <summary>
        /// Get all points from the shape for animation purposes
        /// </summary>
        /// <param name="iterations">Number of repeats</param>
        /// <param name="formPattern">ENUM FormPattern</param>
        /// <returns>List of points for every point from shape</returns>
        /// <exception cref="Exception">Pattern not found</exception>
        public List<PointF> GetAllPoints(int iterations, FormPattern formPattern)
        {
            List<PointF> allPoints = new();
            
            //Set first point
            allPoints.Add(new PointF(_startPoint.X, _startPoint.Y));

            //Set rest of points from the shape
            allPoints.AddRange(GetShapePoints(iterations, formPattern));
            return allPoints;
        }

        /// <summary>
        /// Get Bitmap from the shape 
        /// </summary>
        /// <param name="iterations">Number of repeats</param>
        /// <param name="formPattern">ENUM FormPattern</param>
        /// <returns>Bitmap</returns>
        /// <exception cref="Exception">Pattern not found</exception>
        public Bitmap GetBitmap(int iterations, FormPattern formPattern)
        {
            List<PointF> allPoints = new();
            Bitmap bitmap = new(ImgWidth, ImgHeight);
            
            //Set first point 
            allPoints.Add(new PointF(_startPoint.X, _startPoint.Y));
            //Set rest of points from shape
            allPoints.AddRange(GetShapePoints(iterations, formPattern));
            //Add every point to bitmap
            allPoints.ForEach(point => bitmap.SetPixel((int)point.X, (int)point.Y, Color));
            return bitmap;
        }

        /// <summary>
        /// Gets all points from the triangle shape
        /// </summary>
        /// <param name="iterations"></param>
        /// <returns>List of Points from triangle shape</returns>
        private List<PointF> GetTrianglePoints(int iterations)
        {
            List<PointF> points = new();

            //Set triangle points
            List<PointF> trianglePoints = new()
            {
                new Point(ImgWidth / 2, 50), //Upper middle
                new Point(100, ImgHeight - 50), //Left corner
                new Point(ImgWidth - 50, ImgHeight - 50) //Rigth corner
            };
            //Add triangle points to list
            trianglePoints.ForEach(point => points.Add(new PointF(point.X, point.Y)));

            //Set random lastpoint for the first iteration
            PointF lastPoint = new PointF(_random.Next(0, ImgWidth), _random.Next(0, ImgHeight));
            for (int i = 0; i < iterations; i++)
            {
                int r = _random.Next(0, 3);
                //Save actually point
                PointF actualPoint = new PointF(lastPoint.X, lastPoint.Y);

                //Calculate next point within the shape points
                actualPoint.X = (trianglePoints[r].X + actualPoint.X) / 2;
                actualPoint.Y = (trianglePoints[r].Y + actualPoint.Y) / 2;

                //Add point to list
                points.Add(actualPoint);
                lastPoint = actualPoint;
            }
            return points;
        }

        /// <summary>
        /// Gets all points from the square1 shape
        /// </summary>
        /// <param name="iterations"></param>
        /// <returns>List of Points from square1 shape</returns>
        private List<PointF> GetSquare1Points(int iterations)
        {
            List<PointF> points = new();

            //Set square1 points
            List<PointF> square1Points = new()
            {
                new Point(10, 10), //Left upper corner
                new Point(10, ImgHeight - 10), //Right upper corner
                new Point(ImgWidth - 10, 10), //Left lower corner
                new Point(ImgWidth - 10, ImgHeight - 10), //Right lower corner
                new Point(ImgWidth / 2 + 10, ImgHeight / 2 + 10) //Middle point
            };

            //Add every square1 shape points to list
            square1Points.ForEach(point => points.Add(new PointF(point.X, point.Y)));

            //Set random lastpoint for the first iteration
            PointF lastPoint = new PointF(_random.Next(0, ImgWidth), _random.Next(0, ImgHeight));
            for (int i = 0; i < iterations; i++)
            {
                int r = _random.Next(0, 5);
                //Save actually point
                PointF actualPoint = new PointF(lastPoint.X, lastPoint.Y);

                //Calculate next point within the form points
                actualPoint.X = (square1Points[r].X + actualPoint.X) / 3;
                actualPoint.Y = (square1Points[r].Y + actualPoint.Y) / 3;
                //Add point to list
                points.Add(actualPoint);
                lastPoint = actualPoint;
            }

            return points;
        }

        /// <summary>
        /// Gets all points from the square2 shape
        /// </summary>
        /// <param name="iterations"></param>
        /// <returns>List of Points from square2 shape</returns>
        private List<PointF> GetSquare2Points(int iterations)
        {
            List<PointF> points = new();

            //Set square2 points
            List<PointF> square2Points = new()
            {
                new Point(10, 10), //Left upper corner
                new Point(10, ImgHeight - 10), //Rigth upper corner
                new Point(ImgHeight  - 10, 10), //Left lower corner
                new Point(ImgHeight  - 10, ImgHeight  - 10), //Right lower corner
            };

            //Add every square2 shape points to list
            square2Points.ForEach(point => points.Add(new PointF(point.X, point.Y)));

            //Set random lastpoint for the first iteration
            PointF lastPoint = new PointF(_random.Next(0, ImgWidth), _random.Next(0, ImgHeight));
            int lastVertex = _random.Next(0, 4);

            for (int i = 0; i < iterations; i++)
            {
                PointF nextPoint = new();
                int vertex = _random.Next(0, 4);

                //The last point can't be the same as the current point 
                if (vertex != lastVertex)
                {
                    nextPoint.X = (square2Points[vertex].X + lastPoint.X) / 2;
                    nextPoint.Y = (square2Points[vertex].Y + lastPoint.Y) / 2;

                    points.Add(nextPoint);
                    lastPoint = nextPoint;
                    lastVertex = vertex;
                }
            }
            return points;
        }

        /// <summary>
        /// Gets all points from the square3 shape
        /// </summary>
        /// <param name="iterations"></param>
        /// <returns>List of Points from the square3 shape</returns>
        private List<PointF> GetSquare3Points(int iterations)
        {
            List<PointF> points = new();

            //Set square3 points
            List<PointF> square3Points = new()
            {
                new Point(10, 10), //Left upper corner
                new Point(10, ImgHeight - 10), //Right upper corner
                new Point(ImgHeight - 10, 10), //Left lower corner
                new Point(ImgHeight - 10, ImgHeight - 10), //Right lower corner
                new Point(ImgHeight / 2 + 10, ImgHeight / 2 + 10) //Middle point
            };

            //Add every square3 shape points to list
            square3Points.ForEach(point => points.Add(new PointF(point.X, point.Y)));

            //Set random lastpoint for the first iteration
            PointF lastPoint = new PointF(_random.Next(0, ImgWidth), _random.Next(0, ImgHeight));
            int lastVertex = _random.Next(0, 5);

            for (int i = 0; i < iterations; i++)
            {
                PointF nextPoint = new();
                int vertex = _random.Next(0, 5);

                //The last point can't be the same as the current point 
                if (vertex != lastVertex)
                {
                    nextPoint.X = (square3Points[vertex].X + lastPoint.X) / 2;
                    nextPoint.Y = (square3Points[vertex].Y + lastPoint.Y) / 2;

                    points.Add(nextPoint);
                    lastPoint = nextPoint;
                    lastVertex = vertex;
                }
            }
            return points;
        }

        /// <summary>
        /// Gets all points from the pentagon shape
        /// </summary>
        /// <param name="iterations"></param>
        /// <returns>List of Points from the pentagon shape</returns>
        private List<PointF> GetPentagonPoints(int iterations)
        {
            List<PointF> points = new();

            //Set pentagon points
            List<PointF> pentagonPoints = new()
            {
                new Point(200, 0),
                new Point(0, 150),
                new Point(400, 150),
                new Point(100, 400),
                new Point(300, 400),
            };

            //Add every pentagon shape points to list
            pentagonPoints.ForEach(point => points.Add(new PointF(point.X, point.Y)));

            //Set random lastpoint for the first iteration
            PointF lastPoint = new PointF(_random.Next(0, ImgWidth), _random.Next(0, ImgHeight));
            int lastVertex = _random.Next(0, 5);

            for (int i = 0; i < iterations; i++)
            {
                PointF nextPoint = new();
                int vertex = _random.Next(0, 5);

                //The last point can't be the same as the current point 
                if (vertex != lastVertex)
                {
                    nextPoint.X = (pentagonPoints[vertex].X + lastPoint.X) / 2;
                    nextPoint.Y = (pentagonPoints[vertex].Y + lastPoint.Y) / 2;

                    points.Add(nextPoint);
                    lastPoint = nextPoint;
                    lastVertex = vertex;
                }
            }
            return points;
        }
    }
}
