using System;

namespace Lab121_06_03
{
	public class Vec3<V>
	{
		private V[] Vec = new V[30];
		
		public Vec3()
		{
		}
		
		public Vec3(int e)
		{
			Vec = new V[e];
		}
		
		public bool tieneX(V X)
		{
			for (int a=0 ; a<Vec.Length ; a++)
			{
				if (Vec[a].Equals(X))
				{
					return true;
				}
			}
			return false;
		}
		
		
		~Vec3(){}
	}
}
