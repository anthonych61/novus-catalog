package com.example.novus_catalog.controllers;

import com.example.novus_catalog.entities.Students;
import com.example.novus_catalog.helpers.DropDownList;
import com.example.novus_catalog.services.StudentServiceImpl;
import com.example.novus_catalog.validation.UserValidator;
import jakarta.servlet.http.HttpSession;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Controller
public class EditController {

    @Autowired
    private StudentServiceImpl studentService;

    @GetMapping("/edit")
    public String getStudentById(HttpSession session, @RequestParam(value = "id", required = false) Long id, Model model) {
        session.setAttribute("id", id);
        Optional<Students> studentsOptional = studentService.findById(id); // retrieve the student by id

        if(studentsOptional.isPresent()) {
            model.addAttribute("formData", studentsOptional.get());

            DropDownList userSelection = new DropDownList();
            userSelection.setDropDownList("--Please select--"); // retain department options on postback
            model.addAttribute("selectedValue", userSelection);
            model.addAttribute("departments", DropDownList.departments);
            return "edit";

        } else { return "redirect:/default"; }

    }
    @PostMapping("/edit")
    public String submitForm(HttpSession session, @Valid @ModelAttribute("formData") Students formData, BindingResult bindingResult,
                             RedirectAttributes redirectAttributes,
                             Model model) {
        List<String> allErrors = new ArrayList<>();
        Long id = (Long)session.getAttribute("id");
        DropDownList userSelection = new DropDownList();

        if (bindingResult.hasErrors()) {
            model.addAttribute("selectedValue", userSelection);
            model.addAttribute("departments", DropDownList.departments);
            redirectAttributes.addFlashAttribute("formData", formData);

            UserValidator userValidator = new UserValidator();
            allErrors = userValidator.validateRegistration(formData);
            model.addAttribute("allErrors", allErrors);
            return "edit";

        } else {

            LocalDateTime currentDateTime = LocalDateTime.now();
            formData.setModifiedDateTime(currentDateTime);
            studentService.update(id, formData);
        }
        return "redirect:/default";

    }
}
