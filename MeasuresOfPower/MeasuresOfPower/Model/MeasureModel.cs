namespace MeasuresOfPower
{
    public class MeasureModel
    {
        public string Measures { get; set; }
        public double US { get; set; }
        public double China { get; set; }
        public AnnotationModel AnnotationValue { get; set; }

        public MeasureModel(string measures, double us, double china, AnnotationModel annotationValue)
        {
            Measures = measures;
            US = us;
            China = china;
            AnnotationValue = annotationValue;
            AnnotationValue.Text = measures;
        }
    }

    public class AnnotationModel
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public string? Text { get; set; }
        public double TextX { get; set; }
        public double TextY { get; set; }
    }
}