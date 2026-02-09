namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class ModuleScript : BaseScript
	{
		public override bool Weaved()
		{
			return false;
		}
	}
}
