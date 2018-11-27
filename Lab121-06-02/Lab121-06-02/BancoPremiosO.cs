using System;

namespace Lab121_06_02
{
	public class BancoPremiosO<W,T,Z>
	{
		private int nroPremios;
		private PremioOscar<W,T,Z>[] Pi = new PremioOscar<W, T, Z>[30];
		
		public BancoPremiosO()
		{
			nroPremios =0;
		}
		
		
		~BancoPremiosO(){}
	}
}
