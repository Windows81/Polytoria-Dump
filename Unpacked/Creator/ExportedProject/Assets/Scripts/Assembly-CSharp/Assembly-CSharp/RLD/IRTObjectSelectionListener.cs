namespace RLD;

[Token(Token = "0x200029A")]
public interface IRTObjectSelectionListener
{

	[Token(Token = "0x6001904")]
	public bool OnCanBeSelected(ObjectSelectEventArgs selectArgs) { }

	[Token(Token = "0x6001906")]
	public void OnDeselected(ObjectDeselectEventArgs deselectArgs) { }

	[Token(Token = "0x6001905")]
	public void OnSelected(ObjectSelectEventArgs selectArgs) { }

}

