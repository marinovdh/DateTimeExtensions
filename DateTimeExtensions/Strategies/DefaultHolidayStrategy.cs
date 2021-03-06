﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeExtensions.Strategies {
	public class DefaultHolidayStrategy : IHolidayStrategy {
		IEnumerable<Holiday> holidays;

		public DefaultHolidayStrategy() {
			this.holidays = new List<Holiday>();
		}

		public bool IsHoliDay(DateTime day) {
			return false;
		}

		public IEnumerable<Holiday> Holidays {
			get {
				return holidays;
			}
		}
	}
}
