using System;

namespace Lab121_06_03
{
	public class Mat2x2<A>
	{
		private A[,] Mat = new A[3,3];
		private int nf, nc;
		public Mat2x2()
		{ nf=0;
			nc=0;
		}
		
		public Mat2x2(int f, int col)
		{
			nf=f;
			nc=col;
			Mat = new A[f,col];
		}
		
		public bool tieneX(A X)
		{
			for (int i=0; i<nf; i++)
			{	for (int j=0; j<nc; j++)
				{	if(Mat[i,j].Equals(X))
					{	return true; }
				}
				
			}
			return false;
		}
		
		
		~Mat2x2(){}
	}
}
