import React from 'react';
import ProfileSection from '../../components/sections/ProfileSection/ProfileSection';
import ExperienceSection from '../../components/sections/ExperienceSection/ExperienceSection';
import SkillsSection from '../../components/sections/SkillsSection/SkillsSection';
import EducationSection from '../../components/sections/EducationSection/EducationSection';
import ProjectsSection from '../../components/sections/ProjectsSection/ProjectsSection';
import TestimonialsSection from '../../components/sections/TestimonialsSection/TestimonialsSection';
import ContactSection from '../../components/sections/ContactSection/ContactSection';
import './HomePage.css';

const HomePage: React.FC = () => {
  return (
    <div className="body">
      <ProfileSection />
      <ExperienceSection />
      <SkillsSection />
      <EducationSection />
      <ProjectsSection />
      <TestimonialsSection />
      <ContactSection />
    </div>
  );
};

export default HomePage;
