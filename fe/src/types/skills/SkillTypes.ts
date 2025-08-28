import type { BaseEntity } from '../common/BaseTypes';

export interface Skill extends BaseEntity {
  name: string;
  category: SkillCategory;
  proficiency: number; // 0-100
  yearsOfExperience: number;
  description?: string;
}

export interface SkillCategory extends BaseEntity {
  name: string;
  description?: string;
  color: string;
}

export interface SkillChartData {
  name: string;
  value: number;
  color: string;
}

export interface SoftSkill extends BaseEntity {
  name: string;
  description?: string;
  level: 'Beginner' | 'Intermediate' | 'Advanced' | 'Expert';
}
