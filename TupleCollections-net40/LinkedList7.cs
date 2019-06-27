﻿using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public class LinkedList<T1, T2, T3, T4, T5, T6, T7> : LinkedList<Tuple<T1, T2, T3, T4, T5, T6, T7>>,
		ICollection<T1, T2, T3, T4, T5, T6, T7>
	{
		public void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
			(this as ICollection<Tuple<T1, T2, T3, T4, T5, T6, T7>>).Add(item);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
			return (this as ICollection<Tuple<T1, T2, T3, T4, T5, T6, T7>>).Remove(item);
		}
	}
}
