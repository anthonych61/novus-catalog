package com.example.novus_catalog.controllers;

import com.example.novus_catalog.services.StudentServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class DefaultController {

    @Autowired
    private StudentServiceImpl studentService;

    @GetMapping("/default")
    public String populateStudentRecords(Model model) {
        model.addAttribute("allStudentList", studentService.getAllStudents());
        return "default";
    }

}
