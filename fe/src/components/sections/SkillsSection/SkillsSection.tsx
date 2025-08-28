import React from 'react';
import SkillsChart from '../../charts/SkillsChart/SkillsChart';
import ProgressBar from '../../charts/ProgressBar/ProgressBar';
import { technicalSkills, softSkills } from '../../../data';
import './SkillsSection.css';

const SkillsSection: React.FC = () => {
  return (
    <div className="container-skill">
      <div className="container-skill-header">
        <span>My Skills</span>
      </div>
      <div className="container-skill-content">
        <div className="container-skill-section">
          <span>Technical Proficiency</span>
          {technicalSkills.map((skill) => (
            <div key={skill.id} className="container-skill-item">
              <div className="container-skill-item-header">
                <div>
                  <span>{skill.name}</span>
                </div>
                <div>
                  <span>{skill.proficiency}%</span>
                </div>
              </div>
              <ProgressBar 
                value={skill.proficiency} 
                color={skill.category.color}
              />
            </div>
          ))}
        </div>
        <div className="container-skill-section">
          <div><span>Skill Overview</span></div>
          <SkillsChart />
          <div>
            <div>
              <span>Soft Skills</span>
            </div>
            <div className="container-soft-skill">
              {softSkills.map((skill) => (
                <div key={skill.id} className="container-soft-skill-item">
                  <span>{skill.name}</span>
                </div>
              ))}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default SkillsSection;
