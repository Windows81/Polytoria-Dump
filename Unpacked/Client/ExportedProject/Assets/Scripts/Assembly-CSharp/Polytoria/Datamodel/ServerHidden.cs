namespace Polytoria.Datamodel
{
	public class ServerHidden : Instance
	{
		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
