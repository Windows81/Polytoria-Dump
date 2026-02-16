namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class Model : DynamicInstance
	{
		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
