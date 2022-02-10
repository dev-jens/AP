package edu.ap.webservice.grading.jpa;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface GradingRepository extends CrudRepository<Grade, Long>{
    
}
