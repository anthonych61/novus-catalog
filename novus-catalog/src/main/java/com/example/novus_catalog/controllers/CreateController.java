package com.example.novus_catalog.controllers;

import com.example.novus_catalog.entities.Students;
import com.example.novus_catalog.helpers.DropDownList;
import com.example.novus_catalog.services.StudentServiceImpl;
import com.example.novus_catalog.validation.UserValidator;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

@Controller
public class CreateController {

    @Autowired
    private StudentServiceImpl studentService;

    @GetMapping("/registration")
    public String form(Model model) {
        DropDownList userSelection = new DropDownList();

        model.addAttribute("formData", new Students());
        userSelection.setDropDownList("--Please select--"); // retain department options on postback
        model.addAttribute("selectedValue", userSelection);
        model.addAttribute("departments", DropDownList.departments);
        return "registration";
    }

    @PostMapping("/registration")
    public String submitForm(@RequestParam(value = "action", required = false) String action, @Valid @ModelAttribute("formData") Students formData,
                             BindingResult bindingResult,
                             Model model) {
        List<String> allErrors = new ArrayList<>();
        DropDownList userSelection = new DropDownList();

        if ("cancel".equals(action)) { return "redirect:/default"; }
        else if ("save".equals(action)) {
            if (bindingResult.hasErrors()) {
                model.addAttribute("selectedValue", userSelection);
                model.addAttribute("departments", DropDownList.departments);

                UserValidator userValidator = new UserValidator();
                allErrors = userValidator.validateRegistration(formData);
                model.addAttribute("allErrors", allErrors);

                return "registration";
            } else {
                LocalDateTime currentDateTime = LocalDateTime.now();
                formData.setCreatedDateTime(currentDateTime);
                formData.setModifiedDateTime(currentDateTime);
                studentService.save(formData);
            }
        }
        return "redirect:/default";
    }

    @PostMapping("/cancel-handler")
    public String cancelForm() {
        return "redirect:/default";
    }

}


