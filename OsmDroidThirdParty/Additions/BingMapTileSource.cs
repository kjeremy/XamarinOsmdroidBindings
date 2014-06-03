using Android.Runtime;

namespace OsmDroid.TileProvider.TileSource.Bing
{
    public partial class BingMapTileSource
    {
        Java.Lang.Object IStyledTileSource.Style
        {
            get { return new Java.Lang.String(Style); }
            set { Style = (string)value.JavaCast<Java.Lang.String>(); }
        }

        public void SetStyle(string value)
        {
            Style = value;
        }
    }
}