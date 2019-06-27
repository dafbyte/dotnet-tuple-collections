﻿using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public class LinkedList<T1, T2, T3, T4, T5, T6> : LinkedList<Tuple<T1, T2, T3, T4, T5, T6>>,
		ICollection<T1, T2, T3, T4, T5, T6>
	{
		public void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
			(this as ICollection<Tuple<T1, T2, T3, T4, T5, T6>>).Add(item);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
			return (this as ICollection<Tuple<T1, T2, T3, T4, T5, T6>>).Remove(item);
		}
	}
}
