namespace Unity.Collections;

[DebuggerDisplay("Key = {Key}, Value = {Value}")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x2000026")]
public struct KVPair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005D")]
	internal HashMapHelper<TKey>* m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005E")]
	internal int m_Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005F")]
	internal int m_Next; //Field offset: 0x0

}

