import React from 'react';
import { experienceData } from '../../../data';
import './ExperienceSection.css';

const ExperienceSection: React.FC = () => {
  const formatDate = (date: Date) => {
    return date.toLocaleDateString('en-US', { month: 'short', year: 'numeric' });
  };

  const formatDateRange = (startDate: Date, endDate?: Date, isCurrent?: boolean) => {
    const start = formatDate(startDate);
    if (isCurrent) {
      return `${start} – Present`;
    }
    if (endDate) {
      return `${start} – ${formatDate(endDate)}`;
    }
    return start;
  };

  return (
    <div className="container-experience">
      <div className="container-experience-header">
        <span>Professional Experience</span>
      </div>
      <div className="container-experience-content-wrapper">
        {experienceData.map((experience) => (
          <div key={experience.id} className="container-experience-content">
            <div className="container-experience-content-title">
              <span>{experience.title}</span>
            </div>
            <div className="container-experience-content-subtitle">
              <span>
                {experience.company}, {experience.location} | {formatDateRange(experience.startDate, experience.endDate, experience.isCurrent)}
              </span>
            </div>
            {experience.achievements.map((achievement, index) => (
              <div key={index} className="container-experience-content-detail">
                <span>{achievement}</span>
              </div>
            ))}
          </div>
        ))}
      </div>
    </div>
  );
};

export default ExperienceSection;
