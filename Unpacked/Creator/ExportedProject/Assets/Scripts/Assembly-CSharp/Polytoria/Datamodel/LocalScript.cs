namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class LocalScript : BaseScript
	{
		public override bool Weaved()
		{
			return false;
		}
	}
}
