namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class Truss : Climbable
	{
		protected override void Awake()
		{
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
