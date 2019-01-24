namespace CarLot.Lesson2Encapsulation.Example
{
	public interface IThing<TId>
	{
		TId Id { get; }

		bool HasSameId(TId id);

		TId GetIdFromString(string idString);

		string GetStringFromId(TId id);

		void WriteSummary();
	}
}
