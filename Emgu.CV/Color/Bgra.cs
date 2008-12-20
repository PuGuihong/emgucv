using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV.Structure;

namespace Emgu.CV
{
   ///<summary> 
   ///Defines a Bgra (Blue Green Red Alpha) color
   ///</summary>
   [ColorInfo(ConversionCodename = "BGRA")]
   public class Bgra : ColorType, IEquatable<Bgra>
   {
      /// <summary>
      /// Create a BGRA color using the specific values
      /// </summary>
      public Bgra()
         : base()
      {
      }

      ///<summary> Create a BGRA color using the specific values</summary>
      ///<param name="blue"> The blue value for this color </param>
      ///<param name="green"> The green value for this color </param>
      ///<param name="red"> The red value for this color </param>
      ///<param name="alpha"> The alpha value for this color</param>
      public Bgra(double blue, double green, double red, double alpha)
         : base(new MCvScalar(blue, green, red, alpha))
      {
      }

      ///<summary> Get or set the intensity of the blue color channel </summary>
      [DisplayColor(255, 0, 0)]
      public double Blue { get { return _scalar.v0; } set { _scalar.v0 = value; } }

      ///<summary> Get or set the intensity of the green color channel </summary>
      [DisplayColor(0, 255, 0)]
      public double Green { get { return _scalar.v1; } set { _scalar.v1 = value; } }

      ///<summary> Get or set the intensity of the red color channel </summary>
      [DisplayColor(0, 0, 255)]
      public double Red { get { return _scalar.v2; } set { _scalar.v2 = value; } }

      ///<summary> Get or set the intensity of the alpha color channel </summary>
      [DisplayColor(122, 122, 122)]
      public double Alpha { get { return _scalar.v3; } set { _scalar.v3 = value; } }


      #region IEquatable<Bgra> Members

      /// <summary>
      /// Return true if the two color equals
      /// </summary>
      /// <param name="other">The other color to compare with</param>
      /// <returns>true if the two color equals</returns>
      public bool Equals(Bgra other)
      {
         return MCvScalar.Equals(other.MCvScalar);
      }

      #endregion
      /// <summary>
      /// Get the dimension of this color
      /// </summary>
      public override int Dimension
      {
         get { return 4; }
      }
   }
}
