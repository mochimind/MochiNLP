using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Mochi.foundation.data {
	public class SQL {
		private static int SERVER_PORT = 3306;
		private static string SERVER_IP = "34.210.182.221";
		private static string DATABASE = "toutl";
		private static string UID = "test";
		private static string PASS = "bigcahuna";

		public static Object key;

		public static MySqlConnection GetConnection() {
			if (key == null) { key = new object(); }

			lock(key) {
				MySqlConnection conn = new MySqlConnection("Server=" + SERVER_IP +
						";Port=" + SERVER_PORT +
						";Database=" + DATABASE +
						";Uid=" + UID +
						";Pwd=" + PASS + ";");
				conn.Open();

				return conn;
			}
		}
	}
}
