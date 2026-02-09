namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class ScriptInstance : BaseScript
	{
		public override bool Weaved()
		{
			return false;
		}
	}
}
