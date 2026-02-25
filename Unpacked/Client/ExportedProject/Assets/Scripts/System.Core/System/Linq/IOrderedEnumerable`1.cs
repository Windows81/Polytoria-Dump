namespace System.Linq;

[Token(Token = "0x200002B")]
public interface IOrderedEnumerable : IEnumerable<TElement>, IEnumerable
{

	[Token(Token = "0x6000102")]
	public IOrderedEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

}

