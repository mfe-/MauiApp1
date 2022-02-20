﻿using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    /// <summary>
    /// https://github.com/dotnet/docs-maui/blob/main/docs/user-interface/controls/graphicsview.md
    /// </summary>
    /// <example>
    /// <local:GraphicsView Drawable="{StaticResource drawable}" WidthRequest="300" HeightRequest="400" >
    ///         <x:Array Type = "{x:Type shape:IShape}" >
    ///             < Path Fill="#FF502D16" Data="M122.037181 73.3037037 C122.037181 109.1 94.9029248 138.118519 61.4299587 138.118519 C27.9581001 138.118519 0.822736364 109.1 0.822736364 73.3037037 C0.822736364 37.5074074 27.9569926 8.48888889 61.4299587 8.48888889 C94.9018174 8.48888889 122.037181 37.5074074 122.037181 73.3037037 L122.037181 73.3037037 Z"/>
    ///             <Path Fill = "#FFA05A2C" Data="M106.19796 83.3331702 C106.19796 108.901749 87.6972207 129.629096 64.8746074 129.629096 C42.0527494 129.629096 23.5512546 108.901749 23.5512546 83.3331702 C23.5512546 57.7645917 42.0519943 37.0372443 64.8746074 37.0372443 C87.6964653 37.0372443 106.19796 57.7645917 106.19796 83.3331702 L106.19796 83.3331702 Z"/>
    ///             <Path Fill = "#FF502D16" Data="M399.5909 72.5324074 C399.5909 108.328704 372.456644 137.347222 338.983678 137.347222 C305.511819 137.347222 278.376455 108.328704 278.376455 72.5324074 C278.376455 36.7361111 305.510712 7.71759259 338.983678 7.71759259 C372.455536 7.71759259 399.5909 36.7361111 399.5909 72.5324074 L399.5909 72.5324074 Z"/>
    ///             <Path Fill = "#FFA05A2C" Data="M383.751679 82.5618739 C383.751679 108.130453 365.25094 128.8578 342.428326 128.8578 C319.606469 128.8578 301.104974 108.130453 301.104974 82.5618739 C301.104974 56.9932954 319.605713 36.265948 342.428326 36.265948 C365.250184 36.265948 383.751679 56.9932954 383.751679 82.5618739 L383.751679 82.5618739 Z"/>
    ///             <Path Fill = "#FF502D16" Data="M201.239669 0 C411.099174 18.7805556 397.256198 277.296296 198.487603 361.111111 C-19.7024793 254.833333 9.68595041 9.06481481 201.239669 0 Z"/>
    ///             <Path Fill = "#FFD38D5F" Data="M201.239669 58.9472222 C377.297521 12.8824074 325.305785 234.169444 205.371901 250.308333 C89.5206612 249.289815 2.2892562 10.5398148 201.239669 58.9472222 Z"/>
    ///             <Path Fill = "#FF241F1C" Data="M267.387938 122.225395 C267.600827 141.380032 256.658967 156.769338 242.947772 156.599025 C229.236577 156.428712 217.949569 140.763291 217.73668 121.608655 C217.523791 102.454017 228.465651 87.0647113 242.176846 87.2350243 C255.888041 87.4053373 267.175049 103.070758 267.387938 122.225395 Z" />
    ///             <Path Fill = "#FF241F1C" Data="M175.101775 122.379402 C174.888887 141.534039 163.601877 157.19946 149.890683 157.369773 C136.179488 157.540086 125.237629 142.15078 125.450517 122.996143 C125.663406 103.841505 136.950414 88.1760849 150.661609 88.0057719 C164.372804 87.8354589 175.314664 103.224764 175.101775 122.379402 Z" />
    ///             <Path Fill = "#FFD38D5F" Data="M326.308234 269.31113 C326.308234 341.333278 270.498044 399.718537 201.650289 399.718537 C132.804813 399.718537 76.992345 341.333278 76.992345 269.31113 C76.992345 197.288981 132.802535 138.903722 201.650289 138.903722 C270.495765 138.903722 326.308234 197.288981 326.308234 269.31113 L326.308234 269.31113 Z"/>
    ///             <Path Fill = "#FF241F1C" Data="M104.702479 345.225 C169.520661 360.787037 234.338843 366.664815 299.157025 341.8375 C243.776033 368.156019 181.991736 377.384722 104.702479 345.225 L104.702479 345.225 Z"/>
    ///             <Path Fill = "#FF241F1C" Data="M198.066116 174.993519 C195.075124 227.067593 194.034463 279.123148 199.177686 331.113889 C193.755041 286.700926 191.76 237.113889 198.066116 174.993519 Z"/>
    ///             <Path Fill = "#FF241F1C" Data="M183.330579 195.215741 C183.330579 203.3125 181.172149 209.875926 178.509669 209.875926 C175.847107 209.875926 173.68876 203.312222 173.68876 195.215741 C173.68876 187.118981 175.84719 180.555556 178.509669 180.555556 C181.172231 180.555556 183.330579 187.119259 183.330579 195.215741 Z"/>
    ///             <Path Fill = "#FF241F1C" Data="M220.107438 195.061111 C220.107438 203.15787 217.949008 209.721296 215.286529 209.721296 C212.623967 209.721296 210.46562 203.157593 210.46562 195.061111 C210.46562 186.964352 212.62405 180.400926 215.286529 180.400926 C217.949091 180.400926 220.107438 186.96463 220.107438 195.061111 Z"/>
    ///             <Path Fill = "#FFE3DEDB" Data="M263.347107 112.197222 C262.180579 131.525926 252.966942 138.837963 240.640496 141.500926 C248.209256 142.496667 252.414876 151.85 259.983471 136.771574 C261.643719 128.885556 265.049835 122.658611 263.34686 112.196574 L263.347107 112.197222 Z"/>
    ///             <Path Fill = "#FFE3DEDB" Data="M167.917355 108.428704 C171.621488 126.532407 164.771901 136.184259 153.840496 142.568519 C161.206612 141.06213 167.485124 148.2975 170.858678 132.046296 C170.461355 124.281759 172.118099 117.480556 167.917686 108.428704 L167.917355 108.428704 Z"/>
    ///         </x:Array>
    ///     </local:GraphicsView>
    /// </example>
    [ContentProperty("Content")]
    public class GraphicsView : Microsoft.Maui.Controls.GraphicsView, IDrawable
    {
        public static readonly BindableProperty ContentProperty = BindableProperty.Create(nameof(Content), typeof(object), typeof(IList<IShape>), propertyChanged: ContentPropertyChanged);

        private static void ContentPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (bindable is GraphicsView graphicsView)
            {
                graphicsView.Drawable = graphicsView;
            }
        }

        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            int i = 0;
            foreach (var shape in Content)
            {
                //https://github.com/dotnet/maui/blob/cdf43dafaf2dd30ec8732adcb4df855465e9623f/src/Controls/src/Core/Shapes/PathGeometry.cs
                if (shape is Microsoft.Maui.Controls.Shapes.Path path)
                {
                    //https://docs.microsoft.com/en-us/dotnet/maui/user-interface/graphics/draw#draw-a-path
                    PathBuilder pathBuilder = new PathBuilder();
                    PathF pathF1 = pathBuilder.BuildPath("M122.037181 73.3037037 C122.037181 109.1 94.9029248 138.118519 61.4299587 138.118519 C27.9581001 138.118519 0.822736364 109.1 0.822736364 73.3037037 C0.822736364 37.5074074 27.9569926 8.48888889 61.4299587 8.48888889 C94.9018174 8.48888889 122.037181 37.5074074 122.037181 73.3037037 L122.037181 73.3037037 Z");
                    //canvas.DrawPath(pathF1);
                    PathF pathF = new PathF();
                    if (path.Data is PathGeometry pathGeometry)
                    {
                        foreach (var figure in pathGeometry.Figures)
                        {
                            foreach (var segment in figure.Segments)
                            {
                                if (segment is BezierSegment bezier)
                                {

                                    //pathF.CurveTo(new Point(10 + i, 10 + i), new Point(15 + i, 15 + i), new Point(20 + i, 20 + i));
                                    pathF.CurveTo(bezier.Point1, bezier.Point2, bezier.Point3);
                                    i = i + 5;
                                }
                                else if (segment is LineSegment line)
                                {
                                    //pathF.LineTo(line.Point);
                                }
                            }
                        }
                    }

                    //pathF.MoveTo(40, 10);
                    //pathF.LineTo(70, 80);
                    //pathF.LineTo(10, 50);
                    //pathF.Close();
                    canvas.DrawPath(pathF);
                }
            }

            canvas.StrokeColor = Colors.DarkBlue;
            canvas.StrokeSize = 4;
            //canvas.DrawRectangle(10, 10, 100, 50);
        }

        public IList<IShape> Content
        {
            get => (IList<IShape>)GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }
    }
}
