namespace SimpleFileBrowser;

[Token(Token = "0x2000020")]
public interface IListViewAdapter
{

	[Token(Token = "0x1700002A")]
	public int Count
	{
		[Token(Token = "0x6000113")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002B")]
	public float ItemHeight
	{
		[Token(Token = "0x6000114")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000029")]
	public OnItemClickedHandler OnItemClicked
	{
		[Token(Token = "0x6000111")]
		 get { } //Length: 0
		[Token(Token = "0x6000112")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000115")]
	public ListItem CreateItem() { }

	[Token(Token = "0x6000113")]
	public int get_Count() { }

	[Token(Token = "0x6000114")]
	public float get_ItemHeight() { }

	[Token(Token = "0x6000111")]
	public OnItemClickedHandler get_OnItemClicked() { }

	[Token(Token = "0x6000112")]
	public void set_OnItemClicked(OnItemClickedHandler value) { }

	[Token(Token = "0x6000116")]
	public void SetItemContent(ListItem item) { }

}

