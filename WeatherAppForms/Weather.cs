﻿public class Current {
	public string time                 { get; set; }
	public int    interval             { get; set; }
	public double temperature_2m       { get; set; }
	public int    relative_humidity_2m { get; set; }
	public double rain                 { get; set; }
	public int    weather_code         { get; set; }
}

public class CurrentUnits {
	public string time                 { get; set; }
	public string interval             { get; set; }
	public string temperature_2m       { get; set; }
	public string relative_humidity_2m { get; set; }
	public string rain                 { get; set; }
	public string weather_code         { get; set; }
}

public class Weather {
	public double       latitude              { get; set; }
	public double       longitude             { get; set; }
	public double       generationtime_ms     { get; set; }
	public int          utc_offset_seconds    { get; set; }
	public string       timezone              { get; set; }
	public string       timezone_abbreviation { get; set; }
	public double       elevation             { get; set; }
	public CurrentUnits current_units         { get; set; }
	public Current      current               { get; set; }
}