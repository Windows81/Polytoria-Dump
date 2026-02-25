namespace Unity.Hierarchy;

[Token(Token = "0x2000015")]
public interface IHierarchyProperty
{

	[Token(Token = "0x600004B")]
	public T GetValue(in HierarchyNode node) { }

	[Token(Token = "0x600004C")]
	public void SetValue(in HierarchyNode node, T value) { }

}

