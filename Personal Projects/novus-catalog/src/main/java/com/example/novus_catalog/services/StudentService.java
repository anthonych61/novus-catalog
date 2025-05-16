package com.example.novus_catalog.services;

import com.example.novus_catalog.entities.Students;

import java.util.List;
import java.util.Optional;

public interface StudentService {

    public List<Students> getAllStudents();

    public Students save(Students student);

    public Optional<Students> findById(Long id);

    public List<Students> findAllById(List <Long> id);

    public Students update(Long id, Students updateStudent);

    public void deleteById(Long id);

    public void deleteAllById(List <Long> id);
}
