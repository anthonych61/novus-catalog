package com.example.novus_catalog.controllers;

import com.example.novus_catalog.entities.Users;
import com.example.novus_catalog.services.StudentServiceImpl;
import com.example.novus_catalog.services.UserServiceImpl;
import com.example.novus_catalog.validation.UserValidator;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;
import java.util.ArrayList;
import java.util.List;

@Controller
public class EditPasswordController {

    @Autowired
    private StudentServiceImpl studentService;

    @Autowired
    private UserServiceImpl userService;

    @GetMapping("/edit-password")
    public String edit(Model model) {
        model.addAttribute("formData", new Users());
        return "edit-password";
    }

    @PostMapping("/edit-password")
    public String submitForm(@RequestParam(value = "action", required = false) String action, @Valid @ModelAttribute("formData") Users formData,
                             Model model) {
        List<String> allErrors = new ArrayList<>();
        Users user = new Users();

        if ("cancel".equals(action)) { return "redirect:/edit-password"; }
        else if ("Save".equals(action)) {
            UserValidator userValidator = new UserValidator();
            allErrors = userValidator.validatePasswordChange(formData, userService);
            if (allErrors.size() > 0) {
                model.addAttribute("allErrors", allErrors);
                return "edit-password";
            } else { // save
                if(!formData.getOldMentorPassword().trim().isEmpty() && !formData.getNewMentorPassword().trim().isEmpty()) {
                    userService.changeUserPassword(user,"Mentor", formData.getNewMentorPassword());
                }
                if(!formData.getOldAdminPassword().trim().isEmpty() && !formData.getNewAdminPassword().trim().isEmpty()) {
                    userService.changeUserPassword(user,"Administrator", formData.getNewAdminPassword());
                }

            }

        }
        return "redirect:/default";
    }

    @PostMapping("/cancel")
    public String cancelForm() { return "redirect:/default"; }
}
