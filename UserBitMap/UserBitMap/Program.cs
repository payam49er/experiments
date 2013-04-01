using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;


namespace UserBitMap
{
    
        public class LockBitMap
        {
         Bitmap source = null;
         IntPtr Iptr = IntPtr.Zero;
         BitmapData bitmapData = null;
 
        public byte[] Pixels { get; set; }
        public int Depth { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
 
           

    
}
