using System;

namespace Lab121_06_03
{

	public class Conjunto<A,V>
	{
		private int n;
		private MatVec<A,V>[] M = new MatVec<A, V>[30];
		
		
		public Conjunto()
		{
			n=0;
		}
		
		public bool existeX(A X)
		{
			for(int i=0 ; i<n ; i++)
			{
				if (M[i].tieneX(X))
				{
					return true;
				}
			}
			return false;
		}
		
		public bool existeX(V X)
		{
			for(int i=0 ; i<n ; i++)
			{
				if (M[i].tieneX(X))
				{
					return true;
				}
			}
			return false;
		}
		
		~Conjunto(){}
	}
}
