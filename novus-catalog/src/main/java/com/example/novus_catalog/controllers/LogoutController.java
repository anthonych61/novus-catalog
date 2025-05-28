package com.example.novus_catalog.controllers;

import com.example.novus_catalog.entities.Users;
import com.example.novus_catalog.helpers.DropDownList;
import jakarta.servlet.http.HttpSession;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class LogoutController {

    @GetMapping("/logout")
    public String userLogout(HttpSession session, Model model) {
        DropDownList userSelection = new DropDownList();
        model.addAttribute("formData", new Users());
        userSelection.setDropDownList("--Please select--");
        model.addAttribute("selectedValue", userSelection);
        model.addAttribute("accounts", DropDownList.accounts);
        session.invalidate(); // clears the session
        return "login";
    }
}
