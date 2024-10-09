using Syncfusion.UI.Xaml.Charts;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace MeasuresOfPower
{
    public class MeasureData
    {
        public ObservableCollection<MeasureModel> Data { get; set; }
        public AnnotationCollection Annotation { get; set; }

        public MeasureData()
        {
            Data = new ObservableCollection<MeasureModel>()
            {
                new MeasureModel("Reserve Currency Status",1.9, -0.6,new AnnotationModel()
                {
                   X1=0.1, Y1=0, X2=0.1, Y2=2.4, TextX=0.3, TextY=2.4
                }),
                new MeasureModel("Financial Center",2.7, 0.2,new AnnotationModel()
                {
                    X1=1.0, Y1=0 ,X2=1.1, Y2=2.6, TextX=1.3, TextY=2.6
                }),
                new MeasureModel("Economic Output",1.7, 1.6,new AnnotationModel()
                {
                  X1=2.0, Y1=0, X2=2.0, Y2=2.3, TextX=2.2, TextY=2.3
                }),
                new MeasureModel("Trade",1.3, 1.7,new AnnotationModel()
                {
                   X1=3.0, Y1=0, X2=3.0, Y2=-0.5, TextX=3.2, TextY=-0.63
                }),
                new MeasureModel("Military",2.1, 0.9,new AnnotationModel()
                {
                  X1=4.0, Y1=0, X2=4.0, Y2=-0.7, TextX=4.2, TextY=-0.89
                }),
                new MeasureModel("Competitiveness",-0.4,1.0,new AnnotationModel()
                {
                  X1=5.0, Y1=0, X2=5.0, Y2=2.3, TextX=5.2, TextY=2.3
                }),
                new MeasureModel("Innovation and Technology",1.9,1.8 ,new AnnotationModel()
                {
                  X1=6.0, Y1=0, X2=6.0, Y2=-0.3, TextX=6.2, TextY=-0.9
                }),
                new MeasureModel("Education", 2.0, 1.6,new AnnotationModel()
                {
                 X1=7.0, Y1=0, X2=7.0, Y2=-0.3, TextX=7.2, TextY=-0.54
                }),
            };

            Annotation = new AnnotationCollection();

            foreach (var measure in Data)
            {
                Annotation.Add(new LineAnnotation()
                {
                    X1 = measure.AnnotationValue.X1,
                    Y1 = measure.AnnotationValue.Y1,
                    X2 = measure.AnnotationValue.X2,
                    Y2 = measure.AnnotationValue.Y2,
                    StrokeThickness = 1.5,
                    Stroke = new SolidColorBrush(Colors.White),
                    StrokeDashArray = new DoubleCollection() { 2, 3 },
                });

                Annotation.Add(new TextAnnotation()
                {
                    Text = measure.AnnotationValue.Text,
                    X1 = measure.AnnotationValue.TextX,
                    Y1 = measure.AnnotationValue.TextY,
                    Foreground = new SolidColorBrush(Colors.White),
                    FontStyle = FontStyles.Italic,
                    FontSize = 14.5
                });
            }
        }
    }
}