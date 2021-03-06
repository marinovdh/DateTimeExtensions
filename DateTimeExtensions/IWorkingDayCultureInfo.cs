﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeExtensions {
	public interface IWorkingDayCultureInfo {
		bool IsWorkingDay(DateTime date);
		bool IsWorkingDay(DayOfWeek dayOfWeek);
		IEnumerable<Holiday> Holidays { get; }
		string Name { get; }
	}
}
