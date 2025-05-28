package com.example.novus_catalog.helpers;

import java.util.Arrays;
import java.util.List;

public class DropDownList {

    private String ddValue;
    // A list of options for the dropdown
    public static List<String> accounts = Arrays.asList("--Please select--", "Administrator", "Mentor");
    public static List<String> departments = Arrays.asList("--Please select--", "Beni", "Chuquisaca", "Cochabamba", "La Paz", "Oruro", "Pando", "Potosí", "Santa Cruz", "Tarija");

    // getter and setter
    public String getDropDownList() { return ddValue; }
    public void setDropDownList(String value) { this.ddValue = value; }
}
