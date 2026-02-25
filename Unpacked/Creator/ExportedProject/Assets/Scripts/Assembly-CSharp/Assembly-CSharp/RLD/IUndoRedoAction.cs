namespace RLD;

[Token(Token = "0x2000269")]
public interface IUndoRedoAction
{

	[Token(Token = "0x6001855")]
	public void Execute() { }

	[Token(Token = "0x6001858")]
	public void OnRemovedFromUndoRedoStack() { }

	[Token(Token = "0x6001857")]
	public void Redo() { }

	[Token(Token = "0x6001856")]
	public void Undo() { }

}

