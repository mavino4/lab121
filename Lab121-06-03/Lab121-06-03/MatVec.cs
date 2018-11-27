using System;

namespace Lab121_06_03
{
	public class MatVec<A,V>
	{
		private Mat2x2<A> M1;
		private Vec3<V> V1;
		
		public MatVec()
		{
		}
		
		public MatVec(Mat2x2<A> M, Vec3<V> V)
		{
			M1 = M;
			V1 = V;
		}
		
		public bool tieneX(A X)
		{
			if(M1.tieneX(X))
			{
				return true;
			}
			return false;
		}
		
		public bool tieneX(V X)
		{
			if(V1.tieneX(X))
			{
				return true;
			}
			return false;
		}
		
		
		~MatVec(){}
	}
}
