﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeExtensions {
	public static class ChristianHolidays {

		private static Holiday christmas;
		public static Holiday Christmas {
			get {
				if (christmas == null) {
					christmas = new FixedHoliday("Christmas", 12, 25);
				}
				return christmas;
			}
		}

		private static Holiday newYear;
		public static Holiday NewYear {
			get {
				if (newYear == null) {
					newYear = new FixedHoliday("New Year", 1, 1);
				}
				return newYear;
			}
		}

		private static Holiday epiphany;
		public static Holiday Epiphany {
			get {
				if (epiphany == null) {
					epiphany = new FixedHoliday("Epiphany", 1, 6);
				}
				return epiphany;
			}
		}

		private static Holiday assumption;
		public static Holiday Assumption {
			get {
				if (assumption == null) {
					assumption = new FixedHoliday("Assumption", 8, 15);
				}
				return assumption;
			}
		}

		private static Holiday allSaints;
		public static Holiday AllSaints {
			get {
				if (allSaints == null) {
					allSaints = new FixedHoliday("All Saints", 11, 1);
				}
				return allSaints;
			}
		}

		private static Holiday dayOfTheDead;
		public static Holiday DayOfTheDead {
			get {
				if (dayOfTheDead == null) {
					dayOfTheDead = new FixedHoliday("Day of the Dead", 11, 2);
				}
				return dayOfTheDead;
			}
		}

		private static Holiday imaculateConception;
		public static Holiday ImaculateConception {
			get {
				if (imaculateConception == null) {
					imaculateConception = new FixedHoliday("Imaculate Conception", 12, 8);
				}
				return imaculateConception;
			}
		}

		private static Holiday easter;
		public static Holiday Easter {
			get {
				if (easter == null) {
					easter = new EasterBasedHoliday("Easter", 0);
				}
				return easter;
			}
		}

		private static Holiday carnival;
		public static Holiday Carnival {
			get {
				if (carnival == null) {
					carnival = new EasterBasedHoliday("Carnival", -47);
				}
				return carnival;
			}
		}

		private static Holiday goodFriday;
		public static Holiday GoodFriday {
			get {
				if (goodFriday == null) {
					goodFriday = new EasterBasedHoliday("Good Friday", -2);
				}
				return goodFriday;
			}
		}

		private static Holiday easterMonday;
		public static Holiday EasterMonday {
			get {
				if (easterMonday == null) {
					easterMonday = new EasterBasedHoliday("Easter Monday", 1);
				}
				return easterMonday;
			}
		}

		private static Holiday corpusChristi;
		public static Holiday CorpusChristi {
			get {
				if (corpusChristi == null) {
					corpusChristi = new EasterBasedHoliday("Corpus Christi", 60);
				}
				return corpusChristi;
			}
		}

		private static Holiday pentecost;
		public static Holiday Pentecost {
			get {
				if (pentecost == null) {
					pentecost = new EasterBasedHoliday("Pentecost", 50);
				}
				return pentecost;
			}
		}

		private static Holiday ascension;
		public static Holiday Ascension {
			get {
				if (ascension == null) {
					ascension = new EasterBasedHoliday("Ascension", 39);
				}
				return ascension;
			}
		}
	}
}
